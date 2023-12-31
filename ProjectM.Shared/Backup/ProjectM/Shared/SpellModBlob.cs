// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModBlob
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
  public struct SpellModBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Values;
    [FieldOffset(0)]
    public BlobArray<SpellModBlobValue> Values;

    static SpellModBlob()
    {
      Il2CppClassPointerStore<SpellModBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModBlob>.NativeClassPtr);
      SpellModBlob.NativeFieldInfoPtr_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModBlob>.NativeClassPtr, nameof (Values));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
