// Decompiled with JetBrains decompiler
// Type: ProjectM.Door
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Door
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AgeSinceOpened;
    private static readonly System.IntPtr NativeFieldInfoPtr_AutoCloseTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_OpenEntityLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_OpenEntityRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClosedEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastSequenceEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_OpenLeftDoorSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloseLeftDoorSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_OpenRightDoorSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloseRightDoorSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_OpenState;
    private static readonly System.IntPtr NativeFieldInfoPtr_OpenLeftDoor;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastOpenState;
    private static readonly System.IntPtr NativeFieldInfoPtr_SkipNextSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_DenyManualCloseDoor;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanBeOpenedByServant;
    [FieldOffset(0)]
    public double AgeSinceOpened;
    [FieldOffset(8)]
    public float AutoCloseTime;
    [FieldOffset(12)]
    public Entity OpenEntityLeft;
    [FieldOffset(20)]
    public Entity OpenEntityRight;
    [FieldOffset(28)]
    public Entity ClosedEntity;
    [FieldOffset(36)]
    public Entity LastSequenceEntity;
    [FieldOffset(44)]
    public SequenceGUID OpenLeftDoorSequence;
    [FieldOffset(48)]
    public SequenceGUID CloseLeftDoorSequence;
    [FieldOffset(52)]
    public SequenceGUID OpenRightDoorSequence;
    [FieldOffset(56)]
    public SequenceGUID CloseRightDoorSequence;
    [FieldOffset(60)]
    public bool OpenState;
    [FieldOffset(61)]
    public bool OpenLeftDoor;
    [FieldOffset(62)]
    public Nullable_Unboxed<bool> LastOpenState;
    [FieldOffset(64)]
    public bool SkipNextSequence;
    [FieldOffset(65)]
    public bool DenyManualCloseDoor;
    [FieldOffset(66)]
    public bool CanBeOpenedByServant;

    static Door()
    {
      Il2CppClassPointerStore<Door>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Door));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Door>.NativeClassPtr);
      Door.NativeFieldInfoPtr_AgeSinceOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, nameof (AgeSinceOpened));
      Door.NativeFieldInfoPtr_AutoCloseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, nameof (AutoCloseTime));
      Door.NativeFieldInfoPtr_OpenEntityLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, nameof (OpenEntityLeft));
      Door.NativeFieldInfoPtr_OpenEntityRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, nameof (OpenEntityRight));
      Door.NativeFieldInfoPtr_ClosedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, nameof (ClosedEntity));
      Door.NativeFieldInfoPtr_LastSequenceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, nameof (LastSequenceEntity));
      Door.NativeFieldInfoPtr_OpenLeftDoorSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, nameof (OpenLeftDoorSequence));
      Door.NativeFieldInfoPtr_CloseLeftDoorSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, nameof (CloseLeftDoorSequence));
      Door.NativeFieldInfoPtr_OpenRightDoorSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, nameof (OpenRightDoorSequence));
      Door.NativeFieldInfoPtr_CloseRightDoorSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, nameof (CloseRightDoorSequence));
      Door.NativeFieldInfoPtr_OpenState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, nameof (OpenState));
      Door.NativeFieldInfoPtr_OpenLeftDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, nameof (OpenLeftDoor));
      Door.NativeFieldInfoPtr_LastOpenState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, nameof (LastOpenState));
      Door.NativeFieldInfoPtr_SkipNextSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, nameof (SkipNextSequence));
      Door.NativeFieldInfoPtr_DenyManualCloseDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, nameof (DenyManualCloseDoor));
      Door.NativeFieldInfoPtr_CanBeOpenedByServant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Door>.NativeClassPtr, nameof (CanBeOpenedByServant));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Door>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
