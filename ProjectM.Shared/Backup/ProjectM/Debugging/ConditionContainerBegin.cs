// Decompiled with JetBrains decompiler
// Type: ProjectM.Debugging.ConditionContainerBegin
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Debugging
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ConditionContainerBegin
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entities;
    [FieldOffset(0)]
    public BlobAssetReference<ConditionBlob> Condition;
    [FieldOffset(8)]
    public ConditionEntities Entities;

    static ConditionContainerBegin()
    {
      Il2CppClassPointerStore<ConditionContainerBegin>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Debugging", nameof (ConditionContainerBegin));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionContainerBegin>.NativeClassPtr);
      ConditionContainerBegin.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionContainerBegin>.NativeClassPtr, nameof (Condition));
      ConditionContainerBegin.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionContainerBegin>.NativeClassPtr, nameof (Entities));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConditionContainerBegin>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
