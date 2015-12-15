import react from 'react';
import HouseActions from './HousesActions';
import HousesStore from './HousesStore';
 
class Houses extends react.Component {
  constructor() {
    super();
    this.state = HousesStore.getState();
  }

  componentDidMount() {
    HousesStore.listen(this.onChange.bind(this));
  }

  componentWillUnmount() {
    HousesStore.unlisten(this.onChange.bind(this));
  }

  onChange(state) {
    this.setState(state);
  }
 
  render() {
    setTimeout(() => {
      HouseActions.updateHouse();
    }, 2000);
    return (
      <div>
        <p>{this.state.house.name}</p>
      </div>
    );
  }
}

export default Houses;