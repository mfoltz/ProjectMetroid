// Decompiled with JetBrains decompiler
// Type: ProjectM.PlaySequenceOnPickup
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PlaySequenceOnPickup
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PickupSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_InventoryFullSequenceGuid;
    [FieldOffset(0)]
    public SequenceGUID PickupSequenceGuid;
    [FieldOffset(4)]
    public SequenceGUID InventoryFullSequenceGuid;

    static PlaySequenceOnPickup()
    {
      Il2CppClassPointerStore<PlaySequenceOnPickup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PlaySequenceOnPickup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaySequenceOnPickup>.NativeClassPtr);
      PlaySequenceOnPickup.NativeFieldInfoPtr_PickupSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySequenceOnPickup>.NativeClassPtr, nameof (PickupSequenceGuid));
      PlaySequenceOnPickup.NativeFieldInfoPtr_InventoryFullSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySequenceOnPickup>.NativeClassPtr, nameof (InventoryFullSequenceGuid));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlaySequenceOnPickup>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
