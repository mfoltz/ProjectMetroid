// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Buff_ModifyDynamicCollision_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Buff_ModifyDynamicCollision_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Targets;
    private static readonly System.IntPtr NativeFieldInfoPtr_Hardness;
    private static readonly System.IntPtr NativeFieldInfoPtr_PushStrengthMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_PushStrengthMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_AgainstPlayerMods;
    private static readonly System.IntPtr NativeFieldInfoPtr_AgainstUnitsMods;
    [FieldOffset(0)]
    public ModifyDynamicCollisionTargets Targets;
    [FieldOffset(4)]
    public float Hardness;
    [FieldOffset(8)]
    public float PushStrengthMin;
    [FieldOffset(12)]
    public float PushStrengthMax;
    [FieldOffset(16)]
    public Script_Buff_ModifyDynamicCollision_DataServer.Modifications AgainstPlayerMods;
    [FieldOffset(28)]
    public Script_Buff_ModifyDynamicCollision_DataServer.Modifications AgainstUnitsMods;

    static Script_Buff_ModifyDynamicCollision_DataServer()
    {
      Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Buff_ModifyDynamicCollision_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision_DataServer>.NativeClassPtr);
      Script_Buff_ModifyDynamicCollision_DataServer.NativeFieldInfoPtr_Targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision_DataServer>.NativeClassPtr, nameof (Targets));
      Script_Buff_ModifyDynamicCollision_DataServer.NativeFieldInfoPtr_Hardness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision_DataServer>.NativeClassPtr, nameof (Hardness));
      Script_Buff_ModifyDynamicCollision_DataServer.NativeFieldInfoPtr_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision_DataServer>.NativeClassPtr, nameof (PushStrengthMin));
      Script_Buff_ModifyDynamicCollision_DataServer.NativeFieldInfoPtr_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision_DataServer>.NativeClassPtr, nameof (PushStrengthMax));
      Script_Buff_ModifyDynamicCollision_DataServer.NativeFieldInfoPtr_AgainstPlayerMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision_DataServer>.NativeClassPtr, nameof (AgainstPlayerMods));
      Script_Buff_ModifyDynamicCollision_DataServer.NativeFieldInfoPtr_AgainstUnitsMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision_DataServer>.NativeClassPtr, nameof (AgainstUnitsMods));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Modifications
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Hardness;
      private static readonly System.IntPtr NativeFieldInfoPtr_PushStrengthMin;
      private static readonly System.IntPtr NativeFieldInfoPtr_PushStrengthMax;
      [FieldOffset(0)]
      public ModificationId Hardness;
      [FieldOffset(4)]
      public ModificationId PushStrengthMin;
      [FieldOffset(8)]
      public ModificationId PushStrengthMax;

      static Modifications()
      {
        Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision_DataServer.Modifications>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision_DataServer>.NativeClassPtr, nameof (Modifications));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision_DataServer.Modifications>.NativeClassPtr);
        Script_Buff_ModifyDynamicCollision_DataServer.Modifications.NativeFieldInfoPtr_Hardness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision_DataServer.Modifications>.NativeClassPtr, nameof (Hardness));
        Script_Buff_ModifyDynamicCollision_DataServer.Modifications.NativeFieldInfoPtr_PushStrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision_DataServer.Modifications>.NativeClassPtr, nameof (PushStrengthMin));
        Script_Buff_ModifyDynamicCollision_DataServer.Modifications.NativeFieldInfoPtr_PushStrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision_DataServer.Modifications>.NativeClassPtr, nameof (PushStrengthMax));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Buff_ModifyDynamicCollision_DataServer.Modifications>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
