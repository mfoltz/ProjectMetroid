﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.ItemEquipEventData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ItemEquipEventData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EquipmentType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Character;
    [FieldOffset(0)]
    public EquipmentType EquipmentType;
    [FieldOffset(4)]
    public Entity Character;

    static ItemEquipEventData()
    {
      Il2CppClassPointerStore<ItemEquipEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ItemEquipEventData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemEquipEventData>.NativeClassPtr);
      ItemEquipEventData.NativeFieldInfoPtr_EquipmentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemEquipEventData>.NativeClassPtr, nameof (EquipmentType));
      ItemEquipEventData.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemEquipEventData>.NativeClassPtr, nameof (Character));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemEquipEventData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
