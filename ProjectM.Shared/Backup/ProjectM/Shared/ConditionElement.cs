// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.ConditionElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ConditionElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Source;
    private static readonly System.IntPtr NativeFieldInfoPtr_SuccessIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FailureIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Union;
    [FieldOffset(0)]
    public ConditionSource Source;
    [FieldOffset(4)]
    public int SuccessIndex;
    [FieldOffset(8)]
    public int FailureIndex;
    [FieldOffset(16)]
    public ConditionUnion Union;

    static ConditionElement()
    {
      Il2CppClassPointerStore<ConditionElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (ConditionElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionElement>.NativeClassPtr);
      ConditionElement.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionElement>.NativeClassPtr, nameof (Source));
      ConditionElement.NativeFieldInfoPtr_SuccessIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionElement>.NativeClassPtr, nameof (SuccessIndex));
      ConditionElement.NativeFieldInfoPtr_FailureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionElement>.NativeClassPtr, nameof (FailureIndex));
      ConditionElement.NativeFieldInfoPtr_Union = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionElement>.NativeClassPtr, nameof (Union));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConditionElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
