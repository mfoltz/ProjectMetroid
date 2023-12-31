// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.ConditionBlob
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ConditionBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Conditionals;
    private static readonly System.IntPtr NativeFieldInfoPtr_Info;
    [FieldOffset(0)]
    public BlobArray<ConditionElement> Conditionals;
    [FieldOffset(8)]
    public ConditionInfo Info;

    static ConditionBlob()
    {
      Il2CppClassPointerStore<ConditionBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (ConditionBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionBlob>.NativeClassPtr);
      ConditionBlob.NativeFieldInfoPtr_Conditionals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionBlob>.NativeClassPtr, nameof (Conditionals));
      ConditionBlob.NativeFieldInfoPtr_Info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionBlob>.NativeClassPtr, nameof (Info));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConditionBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
