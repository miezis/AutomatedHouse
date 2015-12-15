import react from 'react';
import HouseActions from './HousesActions';
import HousesStore from './HousesStore';
import connectToStores from 'alt/utils/connectToStores';

@connectToStores
class Houses extends react.Component {
  constructor(props) {
    super(props);
  }

  static getStores(props) {
    return [HousesStore];
  }

  static getPropsFromStores(props) {
    return HousesStore.getState();
  }
 
  render() {
    return (
      <div>
        <p>{this.props.house.name}</p>
      </div>
    );
  }
}

export default Houses;