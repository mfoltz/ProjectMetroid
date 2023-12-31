// Decompiled with JetBrains decompiler
// Type: ProjectM.WorkstationAssignedServant
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WorkstationAssignedServant
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ServantEntity;
    [FieldOffset(0)]
    public Entity ServantEntity;

    static WorkstationAssignedServant()
    {
      Il2CppClassPointerStore<WorkstationAssignedServant>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (WorkstationAssignedServant));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkstationAssignedServant>.NativeClassPtr);
      WorkstationAssignedServant.NativeFieldInfoPtr_ServantEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkstationAssignedServant>.NativeClassPtr, nameof (ServantEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorkstationAssignedServant>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
