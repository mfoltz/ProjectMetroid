// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnHitDetection_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_CreateGameplayEventOnHitDetection_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetMainCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetMaterialCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetHitFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_MultipleHits;
    [FieldOffset(0)]
    public MainEntityCategory TargetMainCategory;
    [FieldOffset(1)]
    public MaterialCategory TargetMaterialCategory;
    [FieldOffset(2)]
    public HitFilter TargetHitFilter;
    [FieldOffset(4)]
    public GameplayEventId GameplayEventId;
    [FieldOffset(12)]
    public bool MultipleHits;

    static Script_CreateGameplayEventOnHitDetection_DataServer()
    {
      Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_CreateGameplayEventOnHitDetection_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection_DataServer>.NativeClassPtr);
      Script_CreateGameplayEventOnHitDetection_DataServer.NativeFieldInfoPtr_TargetMainCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection_DataServer>.NativeClassPtr, nameof (TargetMainCategory));
      Script_CreateGameplayEventOnHitDetection_DataServer.NativeFieldInfoPtr_TargetMaterialCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection_DataServer>.NativeClassPtr, nameof (TargetMaterialCategory));
      Script_CreateGameplayEventOnHitDetection_DataServer.NativeFieldInfoPtr_TargetHitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection_DataServer>.NativeClassPtr, nameof (TargetHitFilter));
      Script_CreateGameplayEventOnHitDetection_DataServer.NativeFieldInfoPtr_GameplayEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection_DataServer>.NativeClassPtr, nameof (GameplayEventId));
      Script_CreateGameplayEventOnHitDetection_DataServer.NativeFieldInfoPtr_MultipleHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection_DataServer>.NativeClassPtr, nameof (MultipleHits));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
