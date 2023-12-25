// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.CommandOutput
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CommandOutput
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Translation;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Velocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_MoveVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_AimData;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanDestroyOnCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapCollisionResult;
    [FieldOffset(0)]
    public Translation Translation;
    [FieldOffset(12)]
    public LastTranslation LastTranslation;
    [FieldOffset(24)]
    public Velocity Velocity;
    [FieldOffset(36)]
    public MoveVelocity MoveVelocity;
    [FieldOffset(40)]
    public Rotation Rotation;
    [FieldOffset(56)]
    public EntityAimData AimData;
    [FieldOffset(92)]
    public bool CanDestroyOnCollision;
    [FieldOffset(96)]
    public MapCollisionResult MapCollisionResult;

    static CommandOutput()
    {
      Il2CppClassPointerStore<CommandOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (CommandOutput));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandOutput>.NativeClassPtr);
      CommandOutput.NativeFieldInfoPtr_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandOutput>.NativeClassPtr, nameof (Translation));
      CommandOutput.NativeFieldInfoPtr_LastTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandOutput>.NativeClassPtr, nameof (LastTranslation));
      CommandOutput.NativeFieldInfoPtr_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandOutput>.NativeClassPtr, nameof (Velocity));
      CommandOutput.NativeFieldInfoPtr_MoveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandOutput>.NativeClassPtr, nameof (MoveVelocity));
      CommandOutput.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandOutput>.NativeClassPtr, nameof (Rotation));
      CommandOutput.NativeFieldInfoPtr_AimData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandOutput>.NativeClassPtr, nameof (AimData));
      CommandOutput.NativeFieldInfoPtr_CanDestroyOnCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandOutput>.NativeClassPtr, nameof (CanDestroyOnCollision));
      CommandOutput.NativeFieldInfoPtr_MapCollisionResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandOutput>.NativeClassPtr, nameof (MapCollisionResult));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandOutput>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
