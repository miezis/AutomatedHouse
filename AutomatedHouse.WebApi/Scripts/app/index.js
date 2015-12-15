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


import {Router} from 'react-router';
import {routes} from './route-config';

// For chrome dev tool support
window.React = React;

const router = <Router routes={routes} />;

ReactDOM.render(router, document.getElementById('my-placeholder'));