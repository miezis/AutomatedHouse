import react from 'react';

class Dashboard extends react.Component {
	render() {
		return (
			<div>
				<h1>Dashboard</h1>
				{this.props.children}
			</div>
		);
	}
}

export default Dashboard;