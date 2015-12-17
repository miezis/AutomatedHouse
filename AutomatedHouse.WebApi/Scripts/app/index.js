import React from 'react';
import Modal from 'react-modal';
import ReactDOM from 'react-dom';
import {Router} from 'react-router';
import {routes} from './route-config';
import createBrowserHistory from 'history/lib/createBrowserHistory';

// For chrome dev tool support
window.React = React;

const history = createBrowserHistory();
const router = <Router history={history} routes={routes} />;

ReactDOM.render(router, document.getElementById('root'));
Modal.setAppElement(document.getElementById('root'));