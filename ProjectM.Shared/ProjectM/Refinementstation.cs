// Decompiled with JetBrains decompiler
// Type: ProjectM.Refinementstation
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Refinementstation
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RefiningStartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputInventoryEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputInventoryEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentRecipeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Status;
    private static readonly System.IntPtr NativeFieldInfoPtr_InventoryPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactiveSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactiveSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_Active;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsWorking;
    [FieldOffset(0)]
    public double RefiningStartTime;
    [FieldOffset(8)]
    public NetworkedEntity InputInventoryEntity;
    [FieldOffset(20)]
    public NetworkedEntity OutputInventoryEntity;
    [FieldOffset(32)]
    public PrefabGUID CurrentRecipeGuid;
    [FieldOffset(36)]
    public RefinementStatus Status;
    [FieldOffset(40)]
    public PrefabGUID InventoryPrefabGuid;
    [FieldOffset(44)]
    public SequenceGUID ActiveSequenceGuid;
    [FieldOffset(48)]
    public SequenceGUID InactiveSequenceGuid;
    [FieldOffset(52)]
    public SequenceState ActiveSequenceState;
    [FieldOffset(60)]
    public SequenceState InactiveSequenceState;
    [FieldOffset(68)]
    public bool Active;
    [FieldOffset(69)]
    public bool IsWorking;

    static Refinementstation()
    {
      Il2CppClassPointerStore<Refinementstation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Refinementstation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Refinementstation>.NativeClassPtr);
      Refinementstation.NativeFieldInfoPtr_RefiningStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Refinementstation>.NativeClassPtr, nameof (RefiningStartTime));
      Refinementstation.NativeFieldInfoPtr_InputInventoryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Refinementstation>.NativeClassPtr, nameof (InputInventoryEntity));
      Refinementstation.NativeFieldInfoPtr_OutputInventoryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Refinementstation>.NativeClassPtr, nameof (OutputInventoryEntity));
      Refinementstation.NativeFieldInfoPtr_CurrentRecipeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Refinementstation>.NativeClassPtr, nameof (CurrentRecipeGuid));
      Refinementstation.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Refinementstation>.NativeClassPtr, nameof (Status));
      Refinementstation.NativeFieldInfoPtr_InventoryPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Refinementstation>.NativeClassPtr, nameof (InventoryPrefabGuid));
      Refinementstation.NativeFieldInfoPtr_ActiveSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Refinementstation>.NativeClassPtr, nameof (ActiveSequenceGuid));
      Refinementstation.NativeFieldInfoPtr_InactiveSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Refinementstation>.NativeClassPtr, nameof (InactiveSequenceGuid));
      Refinementstation.NativeFieldInfoPtr_ActiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Refinementstation>.NativeClassPtr, nameof (ActiveSequenceState));
      Refinementstation.NativeFieldInfoPtr_InactiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Refinementstation>.NativeClassPtr, nameof (InactiveSequenceState));
      Refinementstation.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Refinementstation>.NativeClassPtr, nameof (Active));
      Refinementstation.NativeFieldInfoPtr_IsWorking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Refinementstation>.NativeClassPtr, nameof (IsWorking));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Refinementstation>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
