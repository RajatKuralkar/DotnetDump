using System.Text.Json.Serialization;

namespace Models;
[Serializable]
public enum EmpType{
    FULL_TIME=0,PART_TIME=1,INTERN=2,STUDENT=3
}