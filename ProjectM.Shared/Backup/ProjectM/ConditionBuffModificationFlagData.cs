// Decompiled with JetBrains decompiler
// Type: ProjectM.ConditionBuffModificationFlagData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ConditionBuffModificationFlagData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    [FieldOffset(0)]
    public long ModificationTypes;
    [FieldOffset(8)]
    public BlobAssetReference<ConditionBlob> Condition;

    static ConditionBuffModificationFlagData()
    {
      Il2CppClassPointerStore<ConditionBuffModificationFlagData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ConditionBuffModificationFlagData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionBuffModificationFlagData>.NativeClassPtr);
      ConditionBuffModificationFlagData.NativeFieldInfoPtr_ModificationTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionBuffModificationFlagData>.NativeClassPtr, nameof (ModificationTypes));
      ConditionBuffModificationFlagData.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionBuffModificationFlagData>.NativeClassPtr, nameof (Condition));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConditionBuffModificationFlagData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
