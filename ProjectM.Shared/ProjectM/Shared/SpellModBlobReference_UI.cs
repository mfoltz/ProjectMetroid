﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModBlobReference_UI
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
  public struct SpellModBlobReference_UI
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMod;
    [FieldOffset(0)]
    public BlobAssetReference<SpellModBlob_UI> SpellMod;

    static SpellModBlobReference_UI()
    {
      Il2CppClassPointerStore<SpellModBlobReference_UI>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModBlobReference_UI));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModBlobReference_UI>.NativeClassPtr);
      SpellModBlobReference_UI.NativeFieldInfoPtr_SpellMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModBlobReference_UI>.NativeClassPtr, nameof (SpellMod));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModBlobReference_UI>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
