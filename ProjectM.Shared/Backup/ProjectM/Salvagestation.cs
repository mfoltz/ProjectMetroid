// Decompiled with JetBrains decompiler
// Type: ProjectM.Salvagestation
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Salvagestation
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InputInventoryEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputInventoryEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Progress;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentItemGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Status;
    private static readonly System.IntPtr NativeFieldInfoPtr_InventoryPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactiveSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactiveSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_Active;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsWorking;
    [FieldOffset(0)]
    public NetworkedEntity InputInventoryEntity;
    [FieldOffset(12)]
    public NetworkedEntity OutputInventoryEntity;
    [FieldOffset(24)]
    public float Progress;
    [FieldOffset(28)]
    public PrefabGUID CurrentItemGuid;
    [FieldOffset(32)]
    public SalvageStatus Status;
    [FieldOffset(36)]
    public PrefabGUID InventoryPrefabGuid;
    [FieldOffset(40)]
    public SequenceGUID ActiveSequenceGuid;
    [FieldOffset(44)]
    public SequenceGUID InactiveSequenceGuid;
    [FieldOffset(48)]
    public SequenceState ActiveSequenceState;
    [FieldOffset(56)]
    public SequenceState InactiveSequenceState;
    [FieldOffset(64)]
    public bool Active;
    [FieldOffset(65)]
    public bool IsWorking;

    static Salvagestation()
    {
      Il2CppClassPointerStore<Salvagestation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Salvagestation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Salvagestation>.NativeClassPtr);
      Salvagestation.NativeFieldInfoPtr_InputInventoryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Salvagestation>.NativeClassPtr, nameof (InputInventoryEntity));
      Salvagestation.NativeFieldInfoPtr_OutputInventoryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Salvagestation>.NativeClassPtr, nameof (OutputInventoryEntity));
      Salvagestation.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Salvagestation>.NativeClassPtr, nameof (Progress));
      Salvagestation.NativeFieldInfoPtr_CurrentItemGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Salvagestation>.NativeClassPtr, nameof (CurrentItemGuid));
      Salvagestation.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Salvagestation>.NativeClassPtr, nameof (Status));
      Salvagestation.NativeFieldInfoPtr_InventoryPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Salvagestation>.NativeClassPtr, nameof (InventoryPrefabGuid));
      Salvagestation.NativeFieldInfoPtr_ActiveSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Salvagestation>.NativeClassPtr, nameof (ActiveSequenceGuid));
      Salvagestation.NativeFieldInfoPtr_InactiveSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Salvagestation>.NativeClassPtr, nameof (InactiveSequenceGuid));
      Salvagestation.NativeFieldInfoPtr_ActiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Salvagestation>.NativeClassPtr, nameof (ActiveSequenceState));
      Salvagestation.NativeFieldInfoPtr_InactiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Salvagestation>.NativeClassPtr, nameof (InactiveSequenceState));
      Salvagestation.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Salvagestation>.NativeClassPtr, nameof (Active));
      Salvagestation.NativeFieldInfoPtr_IsWorking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Salvagestation>.NativeClassPtr, nameof (IsWorking));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Salvagestation>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
