/*eslint-disable no-undef*/
import React from 'react';
import {Route, IndexRedirect} from 'react-router';

import DashboardRoot from './views/DashboardRoot';
import Houses from './views/houses/Houses';

const routes = (
    <Route path="/" component={DashboardRoot}>
        <IndexRedirect to="houses" />
        <Route path="houses" component={Houses} />
    </Route>
);

export {routes};
