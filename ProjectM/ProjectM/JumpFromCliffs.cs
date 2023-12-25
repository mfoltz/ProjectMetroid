// Decompiled with JetBrains decompiler
// Type: ProjectM.JumpFromCliffs
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct JumpFromCliffs
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LastTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDot;
    private static readonly System.IntPtr NativeFieldInfoPtr_JumpDownTravelBuffPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_JumpUpBuffPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_CheckAgainstMapFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllowJump;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlockJump;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsInJump;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanJumpDown;
    [FieldOffset(0)]
    public float3 LastTranslation;
    [FieldOffset(12)]
    public ModifiableFloat MaxDot;
    [FieldOffset(20)]
    public PrefabGUID JumpDownTravelBuffPrefabGuid;
    [FieldOffset(24)]
    public PrefabGUID JumpUpBuffPrefabGuid;
    [FieldOffset(28)]
    public MapCollisionFlags CheckAgainstMapFlags;
    [FieldOffset(30)]
    public ModifiableBool AllowJump;
    [FieldOffset(34)]
    public ModifiableBool BlockJump;
    [FieldOffset(38)]
    public bool IsInJump;
    [FieldOffset(39)]
    public bool CanJumpDown;

    static JumpFromCliffs()
    {
      Il2CppClassPointerStore<JumpFromCliffs>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (JumpFromCliffs));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JumpFromCliffs>.NativeClassPtr);
      JumpFromCliffs.NativeFieldInfoPtr_LastTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffs>.NativeClassPtr, nameof (LastTranslation));
      JumpFromCliffs.NativeFieldInfoPtr_MaxDot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffs>.NativeClassPtr, nameof (MaxDot));
      JumpFromCliffs.NativeFieldInfoPtr_JumpDownTravelBuffPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffs>.NativeClassPtr, nameof (JumpDownTravelBuffPrefabGuid));
      JumpFromCliffs.NativeFieldInfoPtr_JumpUpBuffPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffs>.NativeClassPtr, nameof (JumpUpBuffPrefabGuid));
      JumpFromCliffs.NativeFieldInfoPtr_CheckAgainstMapFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffs>.NativeClassPtr, nameof (CheckAgainstMapFlags));
      JumpFromCliffs.NativeFieldInfoPtr_AllowJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffs>.NativeClassPtr, nameof (AllowJump));
      JumpFromCliffs.NativeFieldInfoPtr_BlockJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffs>.NativeClassPtr, nameof (BlockJump));
      JumpFromCliffs.NativeFieldInfoPtr_IsInJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffs>.NativeClassPtr, nameof (IsInJump));
      JumpFromCliffs.NativeFieldInfoPtr_CanJumpDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffs>.NativeClassPtr, nameof (CanJumpDown));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JumpFromCliffs>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
