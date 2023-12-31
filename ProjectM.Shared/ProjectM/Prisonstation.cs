// Decompiled with JetBrains decompiler
// Type: ProjectM.Prisonstation
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Prisonstation
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentRecipeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Progress;
    private static readonly System.IntPtr NativeFieldInfoPtr_Status;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactiveSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactiveSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsWorking;
    [FieldOffset(0)]
    public PrefabGUID CurrentRecipeGuid;
    [FieldOffset(4)]
    public float Progress;
    [FieldOffset(8)]
    public RefinementStatus Status;
    [FieldOffset(12)]
    public SequenceGUID ActiveSequenceGuid;
    [FieldOffset(16)]
    public SequenceGUID InactiveSequenceGuid;
    [FieldOffset(20)]
    public SequenceState ActiveSequenceState;
    [FieldOffset(28)]
    public SequenceState InactiveSequenceState;
    [FieldOffset(36)]
    public bool IsWorking;

    static Prisonstation()
    {
      Il2CppClassPointerStore<Prisonstation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Prisonstation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Prisonstation>.NativeClassPtr);
      Prisonstation.NativeFieldInfoPtr_CurrentRecipeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prisonstation>.NativeClassPtr, nameof (CurrentRecipeGuid));
      Prisonstation.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prisonstation>.NativeClassPtr, nameof (Progress));
      Prisonstation.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prisonstation>.NativeClassPtr, nameof (Status));
      Prisonstation.NativeFieldInfoPtr_ActiveSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prisonstation>.NativeClassPtr, nameof (ActiveSequenceGuid));
      Prisonstation.NativeFieldInfoPtr_InactiveSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prisonstation>.NativeClassPtr, nameof (InactiveSequenceGuid));
      Prisonstation.NativeFieldInfoPtr_ActiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prisonstation>.NativeClassPtr, nameof (ActiveSequenceState));
      Prisonstation.NativeFieldInfoPtr_InactiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prisonstation>.NativeClassPtr, nameof (InactiveSequenceState));
      Prisonstation.NativeFieldInfoPtr_IsWorking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prisonstation>.NativeClassPtr, nameof (IsWorking));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Prisonstation>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
