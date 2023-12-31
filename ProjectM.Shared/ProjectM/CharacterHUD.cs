// Decompiled with JetBrains decompiler
// Type: ProjectM.CharacterHUD
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CharacterHUD
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CacheFlag;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodPrefabType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedName;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedDesc;
    private static readonly System.IntPtr NativeFieldInfoPtr_EnemyColorTeamIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoveredTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideHUD;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisableTargetInfoPanel;
    [FieldOffset(0)]
    public HUDShowFlag CacheFlag;
    [FieldOffset(4)]
    public FixedString64 Name;
    [FieldOffset(68)]
    public CharacterHUDEntryType PrefabType;
    [FieldOffset(69)]
    public CharacterHUDEntryType BloodPrefabType;
    [FieldOffset(72)]
    public float Height;
    [FieldOffset(76)]
    public AssetGuid LocalizedName;
    [FieldOffset(92)]
    public AssetGuid LocalizedDesc;
    [FieldOffset(108)]
    public int EnemyColorTeamIndex;
    [FieldOffset(112)]
    public double HoveredTime;
    [FieldOffset(120)]
    public ModifiableBool HideHUD;
    [FieldOffset(124)]
    public bool DisableTargetInfoPanel;

    static CharacterHUD()
    {
      Il2CppClassPointerStore<CharacterHUD>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CharacterHUD));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUD>.NativeClassPtr);
      CharacterHUD.NativeFieldInfoPtr_CacheFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD>.NativeClassPtr, nameof (CacheFlag));
      CharacterHUD.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD>.NativeClassPtr, nameof (Name));
      CharacterHUD.NativeFieldInfoPtr_PrefabType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD>.NativeClassPtr, nameof (PrefabType));
      CharacterHUD.NativeFieldInfoPtr_BloodPrefabType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD>.NativeClassPtr, nameof (BloodPrefabType));
      CharacterHUD.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD>.NativeClassPtr, nameof (Height));
      CharacterHUD.NativeFieldInfoPtr_LocalizedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD>.NativeClassPtr, nameof (LocalizedName));
      CharacterHUD.NativeFieldInfoPtr_LocalizedDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD>.NativeClassPtr, nameof (LocalizedDesc));
      CharacterHUD.NativeFieldInfoPtr_EnemyColorTeamIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD>.NativeClassPtr, nameof (EnemyColorTeamIndex));
      CharacterHUD.NativeFieldInfoPtr_HoveredTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD>.NativeClassPtr, nameof (HoveredTime));
      CharacterHUD.NativeFieldInfoPtr_HideHUD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD>.NativeClassPtr, nameof (HideHUD));
      CharacterHUD.NativeFieldInfoPtr_DisableTargetInfoPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD>.NativeClassPtr, nameof (DisableTargetInfoPanel));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHUD>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
