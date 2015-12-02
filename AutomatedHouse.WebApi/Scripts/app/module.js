var modulis = {
    test: 'test string',
    printTest: function(message) {
        if (message) {
            console.log(message);
            return;
        }        
        console.log(this.test);
    }
};

module.exports = modulis;