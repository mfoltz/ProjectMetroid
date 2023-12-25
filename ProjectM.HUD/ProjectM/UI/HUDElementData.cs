﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.HUDElementData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HUDElementData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ElementType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    [FieldOffset(0)]
    public PrefabGUID Guid;
    [FieldOffset(4)]
    public HUDElementType ElementType;
    [FieldOffset(8)]
    public Entity Entity;

    static HUDElementData()
    {
      Il2CppClassPointerStore<HUDElementData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (HUDElementData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUDElementData>.NativeClassPtr);
      HUDElementData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDElementData>.NativeClassPtr, nameof (Guid));
      HUDElementData.NativeFieldInfoPtr_ElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDElementData>.NativeClassPtr, nameof (ElementType));
      HUDElementData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDElementData>.NativeClassPtr, nameof (Entity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HUDElementData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
