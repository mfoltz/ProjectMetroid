// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_ApplyBuffOnAggroListTarget_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_ApplyBuffOnAggroListTarget_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewBuffEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_LowPrioBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnFailGameplayEventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExcludeBuffTarget;
    [FieldOffset(0)]
    public float MaxDistance;
    [FieldOffset(4)]
    public PrefabGUID NewBuffEntity;
    [FieldOffset(8)]
    public PrefabGUID LowPrioBuff;
    [FieldOffset(12)]
    public GameplayEventId OnFailGameplayEventId;
    [FieldOffset(20)]
    public bool RandomTarget;
    [FieldOffset(21)]
    public bool ExcludeBuffTarget;

    static Script_ApplyBuffOnAggroListTarget_DataServer()
    {
      Il2CppClassPointerStore<Script_ApplyBuffOnAggroListTarget_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_ApplyBuffOnAggroListTarget_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ApplyBuffOnAggroListTarget_DataServer>.NativeClassPtr);
      Script_ApplyBuffOnAggroListTarget_DataServer.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffOnAggroListTarget_DataServer>.NativeClassPtr, nameof (MaxDistance));
      Script_ApplyBuffOnAggroListTarget_DataServer.NativeFieldInfoPtr_NewBuffEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffOnAggroListTarget_DataServer>.NativeClassPtr, nameof (NewBuffEntity));
      Script_ApplyBuffOnAggroListTarget_DataServer.NativeFieldInfoPtr_LowPrioBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffOnAggroListTarget_DataServer>.NativeClassPtr, nameof (LowPrioBuff));
      Script_ApplyBuffOnAggroListTarget_DataServer.NativeFieldInfoPtr_OnFailGameplayEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffOnAggroListTarget_DataServer>.NativeClassPtr, nameof (OnFailGameplayEventId));
      Script_ApplyBuffOnAggroListTarget_DataServer.NativeFieldInfoPtr_RandomTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffOnAggroListTarget_DataServer>.NativeClassPtr, nameof (RandomTarget));
      Script_ApplyBuffOnAggroListTarget_DataServer.NativeFieldInfoPtr_ExcludeBuffTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffOnAggroListTarget_DataServer>.NativeClassPtr, nameof (ExcludeBuffTarget));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_ApplyBuffOnAggroListTarget_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
