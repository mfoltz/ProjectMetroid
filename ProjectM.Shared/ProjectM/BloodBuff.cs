﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodBuff
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BloodBuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Source;
    [FieldOffset(0)]
    public PrefabGUID Source;

    static BloodBuff()
    {
      Il2CppClassPointerStore<BloodBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BloodBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodBuff>.NativeClassPtr);
      BloodBuff.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodBuff>.NativeClassPtr, nameof (Source));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodBuff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
