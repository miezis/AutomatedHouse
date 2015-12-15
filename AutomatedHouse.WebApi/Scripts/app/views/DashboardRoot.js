import react from 'react';

class DashboardRoot extends react.Component {

	render() {
		return (
			<div>
				<h1>DashboardRoot</h1>
				{this.props.children}
			</div>
		);
	}
}

export default DashboardRoot;