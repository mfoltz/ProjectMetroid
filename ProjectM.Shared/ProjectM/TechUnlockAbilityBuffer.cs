﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.TechUnlockAbilityBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TechUnlockAbilityBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    [FieldOffset(0)]
    public PrefabGUID Guid;

    static TechUnlockAbilityBuffer()
    {
      Il2CppClassPointerStore<TechUnlockAbilityBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TechUnlockAbilityBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TechUnlockAbilityBuffer>.NativeClassPtr);
      TechUnlockAbilityBuffer.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TechUnlockAbilityBuffer>.NativeClassPtr, nameof (Guid));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TechUnlockAbilityBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}