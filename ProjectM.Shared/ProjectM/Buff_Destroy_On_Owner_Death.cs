﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Buff_Destroy_On_Owner_Death
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Buff_Destroy_On_Owner_Death
  {
    static Buff_Destroy_On_Owner_Death()
    {
      Il2CppClassPointerStore<Buff_Destroy_On_Owner_Death>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Buff_Destroy_On_Owner_Death));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Buff_Destroy_On_Owner_Death>.NativeClassPtr);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Buff_Destroy_On_Owner_Death>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
