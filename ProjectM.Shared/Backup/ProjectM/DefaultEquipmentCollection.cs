// Decompiled with JetBrains decompiler
// Type: ProjectM.DefaultEquipmentCollection
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DefaultEquipmentCollection
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Boots;
    private static readonly System.IntPtr NativeFieldInfoPtr_Chest;
    private static readonly System.IntPtr NativeFieldInfoPtr_Gloves;
    private static readonly System.IntPtr NativeFieldInfoPtr_Legs;
    [FieldOffset(0)]
    public PrefabGUID Boots;
    [FieldOffset(4)]
    public PrefabGUID Chest;
    [FieldOffset(8)]
    public PrefabGUID Gloves;
    [FieldOffset(12)]
    public PrefabGUID Legs;

    static DefaultEquipmentCollection()
    {
      Il2CppClassPointerStore<DefaultEquipmentCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DefaultEquipmentCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultEquipmentCollection>.NativeClassPtr);
      DefaultEquipmentCollection.NativeFieldInfoPtr_Boots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEquipmentCollection>.NativeClassPtr, nameof (Boots));
      DefaultEquipmentCollection.NativeFieldInfoPtr_Chest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEquipmentCollection>.NativeClassPtr, nameof (Chest));
      DefaultEquipmentCollection.NativeFieldInfoPtr_Gloves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEquipmentCollection>.NativeClassPtr, nameof (Gloves));
      DefaultEquipmentCollection.NativeFieldInfoPtr_Legs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEquipmentCollection>.NativeClassPtr, nameof (Legs));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DefaultEquipmentCollection>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
