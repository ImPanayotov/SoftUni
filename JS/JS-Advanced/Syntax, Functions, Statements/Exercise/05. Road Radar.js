function checkIfDriverIsInTheSpeedLimit(array){
    let speed = +array[0];
    let area = array[1];

    let motorway = 130;
    let interstate = 90;
    let city = 50;
    let residential = 20;

    if (area === "motorway") {
        if (speed > motorway){
            if (speed <= motorway + 20){
                console.log('speeding');
            }
            else if (speed <= motorway + 40){
                console.log('excessive speeding');
            }
            else if (speed > motorway + 40){
                console.log('reckless driving');
            }
        }
    } 

    else if (area === "interstate") {
        if (speed > interstate){
            if (speed <= interstate + 20){
                console.log('speeding');
            }
            else if (speed <= interstate + 40){
                console.log('excessive speeding');
            }
            else if (speed > interstate + 40){
                console.log('reckless driving');
            }
        }
    }

    else if (area === "city") {
        if (speed > city){
            if (speed <= city + 20){
                console.log('speeding');
            }
            else if (speed <= city + 40){
                console.log('excessive speeding');
            }
            else if (speed > city + 40){
                console.log('reckless driving');
            }
        }
    }

    else if (area === "residential") {
        if (speed > residential){
            if (speed <= residential + 20){
                console.log('speeding');
            }
            else if (speed <= residential + 40){
                console.log('excessive speeding');
            }
            else if (speed > residential + 40){
                console.log('reckless driving');
            }
        }
    }
}

checkIfDriverIsInTheSpeedLimit([40, 'city']);
checkIfDriverIsInTheSpeedLimit([21, 'residential']);
checkIfDriverIsInTheSpeedLimit([120, 'interstate']);
checkIfDriverIsInTheSpeedLimit([200, 'motorway']);
