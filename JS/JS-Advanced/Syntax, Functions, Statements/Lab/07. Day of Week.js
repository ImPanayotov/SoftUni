function dayOfWeek(dayOfWeek){

    let dayOfWeekAsNum;

    switch(dayOfWeek){
        case "Monday": 
            dayOfWeekAsNum = 1;
        break;

        case "Tuesday": 
            dayOfWeekAsNum = 2;
        break;

        case "Wednesday": 
            dayOfWeekAsNum =  3;
        break;

        case "Thursday": 
            dayOfWeekAsNum =  4;
        break;

        case "Friday": 
            dayOfWeekAsNum =  5;
        break;

        case "Saturday": 
            dayOfWeekAsNum =  6;
        break;

        case "Sunday": 
            dayOfWeekAsNum =  7;
        break;

        default:
            return `error`;
    }

    console.log(dayOfWeekAsNum);
}

dayOfWeek("Friday");
