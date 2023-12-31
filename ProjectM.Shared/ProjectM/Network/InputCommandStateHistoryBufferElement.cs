// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.InputCommandStateHistoryBufferElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct InputCommandStateHistoryBufferElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Frame;
    private static readonly System.IntPtr NativeFieldInfoPtr_MovementSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanMove;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasMapCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasDynamicCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsMounted;
    private static readonly System.IntPtr NativeFieldInfoPtr_MountMaxSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsDead;
    [FieldOffset(0)]
    public int Frame;
    [FieldOffset(4)]
    public float MovementSpeed;
    [FieldOffset(8)]
    public bool CanMove;
    [FieldOffset(9)]
    public bool HasMapCollision;
    [FieldOffset(10)]
    public bool HasDynamicCollision;
    [FieldOffset(11)]
    public bool IsMounted;
    [FieldOffset(12)]
    public float MountMaxSpeed;
    [FieldOffset(16)]
    public CommandRotationInput Rotation;
    [FieldOffset(48)]
    public AbilityMovementData AbilityMovement;
    [FieldOffset(136)]
    public bool IsDead;

    static InputCommandStateHistoryBufferElement()
    {
      Il2CppClassPointerStore<InputCommandStateHistoryBufferElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (InputCommandStateHistoryBufferElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputCommandStateHistoryBufferElement>.NativeClassPtr);
      InputCommandStateHistoryBufferElement.NativeFieldInfoPtr_Frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandStateHistoryBufferElement>.NativeClassPtr, nameof (Frame));
      InputCommandStateHistoryBufferElement.NativeFieldInfoPtr_MovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandStateHistoryBufferElement>.NativeClassPtr, nameof (MovementSpeed));
      InputCommandStateHistoryBufferElement.NativeFieldInfoPtr_CanMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandStateHistoryBufferElement>.NativeClassPtr, nameof (CanMove));
      InputCommandStateHistoryBufferElement.NativeFieldInfoPtr_HasMapCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandStateHistoryBufferElement>.NativeClassPtr, nameof (HasMapCollision));
      InputCommandStateHistoryBufferElement.NativeFieldInfoPtr_HasDynamicCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandStateHistoryBufferElement>.NativeClassPtr, nameof (HasDynamicCollision));
      InputCommandStateHistoryBufferElement.NativeFieldInfoPtr_IsMounted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandStateHistoryBufferElement>.NativeClassPtr, nameof (IsMounted));
      InputCommandStateHistoryBufferElement.NativeFieldInfoPtr_MountMaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandStateHistoryBufferElement>.NativeClassPtr, nameof (MountMaxSpeed));
      InputCommandStateHistoryBufferElement.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandStateHistoryBufferElement>.NativeClassPtr, nameof (Rotation));
      InputCommandStateHistoryBufferElement.NativeFieldInfoPtr_AbilityMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandStateHistoryBufferElement>.NativeClassPtr, nameof (AbilityMovement));
      InputCommandStateHistoryBufferElement.NativeFieldInfoPtr_IsDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandStateHistoryBufferElement>.NativeClassPtr, nameof (IsDead));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputCommandStateHistoryBufferElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
