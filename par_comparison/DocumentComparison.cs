using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TXTextControl
{
	public class DocumentComparison
	{
		private TXTextControl.TextControl m_originalDocument;
		private TXTextControl.TextControl m_revisedDocument;

		public DocumentComparison(TXTextControl.TextControl originalDocument, TextControl revisedDocument)
		{
			// Initialize document references
			m_originalDocument = originalDocument;
			m_revisedDocument = revisedDocument;

			// Enable track changes in the original document
			originalDocument.IsTrackChangesEnabled = true;

			// Compare paragraphs between the original and revised documents
			for (int p = 1; p <= m_originalDocument.Paragraphs.Count; p++)
			{
				var offsetSentences = 0;

				// Retrieve the original and revised paragraphs
				Paragraph originalParagraph = m_originalDocument.Paragraphs[p];

				if (p > m_revisedDocument.Paragraphs.Count)
					break; // Break if the revised document has fewer paragraphs than the original document

				Paragraph revisedParagraph = m_revisedDocument.Paragraphs[p];

				// Get the start position of the original paragraph
				var startParagraph = originalParagraph.Start;
				var uncheckedOffset = 0;

				// Check if the text of the original and revised paragraphs differ
				if (originalParagraph.Text != revisedParagraph.Text)
				{
					// Extract sentences from the original and revised paragraphs
					var originalSentences = ExtractSentences(originalParagraph.Text);
					var revisedSentences = ExtractSentences(revisedParagraph.Text);

					// Compare sentences and replace words in the original document
					for (int i = 0; i < originalSentences.Count; i++)
					{
						// Trim sentences and calculate offset
						var originalTrimOffset = originalSentences[i].Length - originalSentences[i].Trim().Length;
						var originalSentence = originalSentences[i].Trim();
						var revisedSentence = revisedSentences[i].Trim();

						// Track changes offset initialization
						int trackedChangeOffset = 0;

						var differences = CompareSentences(originalSentence, revisedSentence);

						// Check if there are any differences
						if (differences.Count == 0)
							uncheckedOffset = originalSentences[i].Length - 1;

						// Apply differences to the original document
						foreach (var difference in differences)
						{
							m_originalDocument.Selection.Start = trackedChangeOffset + startParagraph + offsetSentences +
																   difference.charIndex + originalTrimOffset + uncheckedOffset - 1;

							m_originalDocument.Selection.Length = difference.word.Length;
							m_originalDocument.Selection.Text = difference.replacedWord;

							trackedChangeOffset += difference.replacedWord.Length;
						}

						// Update offset for next sentence
						offsetSentences += originalSentences[i].Length + trackedChangeOffset;
					}
				}
				
			}
		}


		private static List<(string word, int charIndex, string replacedWord)> CompareSentences(string sentence1, string sentence2)
		{
			string[] words1 = sentence1.Split(' ');
			string[] words2 = sentence2.Split(' ');

			List<(string word, int charIndex, string replacedWord)> differences = new List<(string word, int charIndex, string replacedWord)>();

			// Track the character index
			int charIndex = 0;

			// Get the maximum length of the two sentences
			int maxLength = Math.Max(words1.Length, words2.Length);

			// Compare each word in the sentences
			for (int i = 0; i < maxLength; i++)
			{
				// Check if the current word exists in both sentences
				if (i < words1.Length && i < words2.Length)
				{
					// If the words are different, add the word, character index, and replaced word to the list
					if (words1[i] != words2[i])
					{
						differences.Add((words1[i], charIndex, words2[i]));
					}
				}
				// If one of the sentences is shorter, add the extra word to the list
				else if (i < words1.Length)
				{
					differences.Add((words1[i], charIndex, ""));
				}
				else
				{
					differences.Add((words2[i], charIndex, ""));
				}

				// Update the character index for the next word
				if (i < words1.Length)
					charIndex += words1[i].Length + 1; // Add 1 for the space
			}

			return differences;
		}

		public static List<string> ExtractSentences(string input)
		{
			List<string> sentences = new List<string>();

			// Use regular expression to split the input string into sentences but keep white spaces
			string pattern = @"([.!?])";

			// split the input string into sentences with the delimiters
			string[] splitSentences = Regex.Split(input, pattern);
			
			// Trim each sentence and remove empty strings
			foreach (string sentence in splitSentences)
			{
				sentences.Add(sentence);
			}

			return sentences;
		}
	}
}
