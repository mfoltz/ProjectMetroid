// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.InputCommandState
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct InputCommandState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Velocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityAimData;
    private static readonly System.IntPtr NativeFieldInfoPtr_MoveVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControllerEntity;
    [FieldOffset(0)]
    public Translation Translation;
    [FieldOffset(12)]
    public LastTranslation LastTranslation;
    [FieldOffset(24)]
    public Velocity Velocity;
    [FieldOffset(36)]
    public Rotation Rotation;
    [FieldOffset(52)]
    public EntityAimData EntityAimData;
    [FieldOffset(88)]
    public MoveVelocity MoveVelocity;
    [FieldOffset(92)]
    public Entity ControllerEntity;

    static InputCommandState()
    {
      Il2CppClassPointerStore<InputCommandState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (InputCommandState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputCommandState>.NativeClassPtr);
      InputCommandState.NativeFieldInfoPtr_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandState>.NativeClassPtr, nameof (Translation));
      InputCommandState.NativeFieldInfoPtr_LastTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandState>.NativeClassPtr, nameof (LastTranslation));
      InputCommandState.NativeFieldInfoPtr_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandState>.NativeClassPtr, nameof (Velocity));
      InputCommandState.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandState>.NativeClassPtr, nameof (Rotation));
      InputCommandState.NativeFieldInfoPtr_EntityAimData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandState>.NativeClassPtr, nameof (EntityAimData));
      InputCommandState.NativeFieldInfoPtr_MoveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandState>.NativeClassPtr, nameof (MoveVelocity));
      InputCommandState.NativeFieldInfoPtr_ControllerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCommandState>.NativeClassPtr, nameof (ControllerEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputCommandState>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
