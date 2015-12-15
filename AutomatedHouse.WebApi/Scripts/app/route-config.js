/*eslint-disable no-undef*/
import React from 'react';
import {Route} from 'react-router';

// Application
import DashboardRoot from './views/DashboardRoot';
import Houses from './views/houses/Houses';

//import Actions from './route-actions';

const routes = (
    <Route path="/" component={DashboardRoot}>
        <Route path="houses" component={Houses} />
    </Route>
);

export {routes};
