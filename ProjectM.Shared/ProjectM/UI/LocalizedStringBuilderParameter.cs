// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.LocalizedStringBuilderParameter
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LocalizedStringBuilderParameter
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Key;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    [FieldOffset(0)]
    public FixedString128 Key;
    [FieldOffset(128)]
    public FixedString128 Value;

    static LocalizedStringBuilderParameter()
    {
      Il2CppClassPointerStore<LocalizedStringBuilderParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (LocalizedStringBuilderParameter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedStringBuilderParameter>.NativeClassPtr);
      LocalizedStringBuilderParameter.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringBuilderParameter>.NativeClassPtr, nameof (Key));
      LocalizedStringBuilderParameter.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringBuilderParameter>.NativeClassPtr, nameof (Value));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedStringBuilderParameter>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
