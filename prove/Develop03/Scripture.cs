using System;
using System.Security.Cryptography.X509Certificates;

public class Scripture 
{
   private Reference _reference;
   private List<Word> _words;

   private int _numberOfWords;



   public Scripture(Reference reference, string text)
   {
        _reference = reference;
        _words = new List<Word>();

        string[] scriptureWords = text.Split(new char[]{' ', '\t','\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
        
        foreach (string wordText in scriptureWords)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }

        _numberOfWords = scriptureWords.Length;
   }

   public void HideRandomWords(int numberToHide)
   {
        Random random = new Random();

        for(int i = 0; i< numberToHide; i++)
        {
            int randomIndex = random.Next(0, _numberOfWords);

            if(randomIndex >= 0 && randomIndex < _numberOfWords)
            {
                Word word = _words[randomIndex];

                word.Hide();
                
            }
        }    
  
   }

    

   public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        List <string> wordsList = new List<string>();

        foreach (Word word in _words)
        {
            wordsList.Add(word.GetDisplayText());
        }
        string scriptureText = string.Join(" ", wordsList);
        return referenceText + " " + scriptureText;
    }

    public bool IsCompletelyHidden()
    {
        if(_numberOfWords == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public int GetRemainingWordsCount()
    {
        int count = 0;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                count++;
            }
        }
        return count;
    }

}