﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.SmurfProjectile_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SmurfProjectile_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Damage;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    [FieldOffset(0)]
    public float Damage;
    [FieldOffset(4)]
    public float Radius;

    static SmurfProjectile_DataServer()
    {
      Il2CppClassPointerStore<SmurfProjectile_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (SmurfProjectile_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmurfProjectile_DataServer>.NativeClassPtr);
      SmurfProjectile_DataServer.NativeFieldInfoPtr_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmurfProjectile_DataServer>.NativeClassPtr, nameof (Damage));
      SmurfProjectile_DataServer.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmurfProjectile_DataServer>.NativeClassPtr, nameof (Radius));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SmurfProjectile_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}