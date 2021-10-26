const myPromise = new Promise(myExexuteFunc)
    .then(handleFulfilledA)
    .then(handleFulfilledB)
    .catch(handleRejectedAny);

