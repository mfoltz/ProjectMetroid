﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_StealthBush_Environment_Data
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_StealthBush_Environment_Data
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RootEntity;
    [FieldOffset(0)]
    public Entity RootEntity;

    static Script_StealthBush_Environment_Data()
    {
      Il2CppClassPointerStore<Script_StealthBush_Environment_Data>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_StealthBush_Environment_Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_StealthBush_Environment_Data>.NativeClassPtr);
      Script_StealthBush_Environment_Data.NativeFieldInfoPtr_RootEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_StealthBush_Environment_Data>.NativeClassPtr, nameof (RootEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_StealthBush_Environment_Data>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
