# Parcel Delivery
### _A system to automate the internal handling of parcels coming in._
The parcels are coming in at the distribution center and need to be handled by different departments based on their weight and value. 
### Behavior
- Parcels with a weight up to 1 kg are handled by the "Mail" departement.
- Parcels with a weight up to 10 kg are handled by the "Regular" department.
- Parcels with a weight over 10 kg are handled by the "Heavy" department.
- Parcels with a value of over 1000,- need to be signed off by the "Insurance" department.

### Design Pattern

- Factory method


### Tech

- Asp .Net core 5.0 console app
- xUnit

### Build

You can see the output by running below command:

```
// workdir: ./Demo
dotnet run
```


