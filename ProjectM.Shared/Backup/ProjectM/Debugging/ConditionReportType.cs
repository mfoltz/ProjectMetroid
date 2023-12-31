// Decompiled with JetBrains decompiler
// Type: ProjectM.Debugging.ConditionReportType
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Debugging
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ConditionReportType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TypeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_SuccessFetch;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    [FieldOffset(0)]
    public int TypeIndex;
    [FieldOffset(4)]
    public bool SuccessFetch;
    [FieldOffset(8)]
    public Entity Entity;

    static ConditionReportType()
    {
      Il2CppClassPointerStore<ConditionReportType>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Debugging", nameof (ConditionReportType));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionReportType>.NativeClassPtr);
      ConditionReportType.NativeFieldInfoPtr_TypeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionReportType>.NativeClassPtr, nameof (TypeIndex));
      ConditionReportType.NativeFieldInfoPtr_SuccessFetch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionReportType>.NativeClassPtr, nameof (SuccessFetch));
      ConditionReportType.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionReportType>.NativeClassPtr, nameof (Entity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConditionReportType>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
