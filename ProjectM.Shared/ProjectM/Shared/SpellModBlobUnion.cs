// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModBlobUnion
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpellModBlobUnion
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatModValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabModValue;
    [FieldOffset(0)]
    public SpellModValue SpellModValue;
    [FieldOffset(0)]
    public StatModValue StatModValue;
    [FieldOffset(0)]
    public PrefabModValue PrefabModValue;

    static SpellModBlobUnion()
    {
      Il2CppClassPointerStore<SpellModBlobUnion>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModBlobUnion));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModBlobUnion>.NativeClassPtr);
      SpellModBlobUnion.NativeFieldInfoPtr_SpellModValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModBlobUnion>.NativeClassPtr, nameof (SpellModValue));
      SpellModBlobUnion.NativeFieldInfoPtr_StatModValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModBlobUnion>.NativeClassPtr, nameof (StatModValue));
      SpellModBlobUnion.NativeFieldInfoPtr_PrefabModValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModBlobUnion>.NativeClassPtr, nameof (PrefabModValue));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModBlobUnion>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
