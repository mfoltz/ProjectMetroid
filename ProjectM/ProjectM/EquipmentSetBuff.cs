// Decompiled with JetBrains decompiler
// Type: ProjectM.EquipmentSetBuff
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
  public struct EquipmentSetBuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffInstance;
    [FieldOffset(0)]
    public PrefabGUID BuffGUID;
    [FieldOffset(4)]
    public Entity BuffInstance;

    static EquipmentSetBuff()
    {
      Il2CppClassPointerStore<EquipmentSetBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (EquipmentSetBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipmentSetBuff>.NativeClassPtr);
      EquipmentSetBuff.NativeFieldInfoPtr_BuffGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentSetBuff>.NativeClassPtr, nameof (BuffGUID));
      EquipmentSetBuff.NativeFieldInfoPtr_BuffInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipmentSetBuff>.NativeClassPtr, nameof (BuffInstance));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EquipmentSetBuff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
