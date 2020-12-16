function wordsToUpperCase(text) {
    let result = text.toUpperCase()
      .match(/\w+/g)
      .join(', ');
    
    console.log(result);
  }

  wordsToUpperCase('Hi, how are you?');
  