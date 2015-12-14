var testModule = require('./module.js');
import React from 'react';
import ReactDOM from 'react-dom';

testModule.printTest('stringas');
console.log('yeah');

var HelloMessage = React.createClass({
  render: function() {
    return <div>Hello {this.props.name}</div>;
  }
});

ReactDOM.render(<HelloMessage name="John" />, document.getElementById('my-placeholder'));