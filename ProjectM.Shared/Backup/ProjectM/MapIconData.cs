// Decompiled with JetBrains decompiler
// Type: ProjectM.MapIconData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MapIconData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderLocalizedKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubHeaderLocalizedKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_RenderOrder;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetUser;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsSiegeWeapon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowOnMinimap;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClampOnMinimap;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowOutsideVision;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiresReveal;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomImplementation;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllySetting;
    private static readonly System.IntPtr NativeFieldInfoPtr_EnemySetting;
    [FieldOffset(0)]
    public LocalizationKey HeaderLocalizedKey;
    [FieldOffset(16)]
    public LocalizationKey SubHeaderLocalizedKey;
    [FieldOffset(32)]
    public int RenderOrder;
    [FieldOffset(36)]
    public Entity TargetUser;
    [FieldOffset(44)]
    public bool IsSiegeWeapon;
    [FieldOffset(45)]
    public bool ShowOnMinimap;
    [FieldOffset(46)]
    public bool ClampOnMinimap;
    [FieldOffset(47)]
    public bool ShowOutsideVision;
    [FieldOffset(48)]
    public bool RequiresReveal;
    [FieldOffset(49)]
    public bool CustomImplementation;
    [FieldOffset(50)]
    public MapIconShowSettings AllySetting;
    [FieldOffset(51)]
    public MapIconShowSettings EnemySetting;

    static MapIconData()
    {
      Il2CppClassPointerStore<MapIconData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MapIconData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapIconData>.NativeClassPtr);
      MapIconData.NativeFieldInfoPtr_HeaderLocalizedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconData>.NativeClassPtr, nameof (HeaderLocalizedKey));
      MapIconData.NativeFieldInfoPtr_SubHeaderLocalizedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconData>.NativeClassPtr, nameof (SubHeaderLocalizedKey));
      MapIconData.NativeFieldInfoPtr_RenderOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconData>.NativeClassPtr, nameof (RenderOrder));
      MapIconData.NativeFieldInfoPtr_TargetUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconData>.NativeClassPtr, nameof (TargetUser));
      MapIconData.NativeFieldInfoPtr_IsSiegeWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconData>.NativeClassPtr, nameof (IsSiegeWeapon));
      MapIconData.NativeFieldInfoPtr_ShowOnMinimap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconData>.NativeClassPtr, nameof (ShowOnMinimap));
      MapIconData.NativeFieldInfoPtr_ClampOnMinimap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconData>.NativeClassPtr, nameof (ClampOnMinimap));
      MapIconData.NativeFieldInfoPtr_ShowOutsideVision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconData>.NativeClassPtr, nameof (ShowOutsideVision));
      MapIconData.NativeFieldInfoPtr_RequiresReveal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconData>.NativeClassPtr, nameof (RequiresReveal));
      MapIconData.NativeFieldInfoPtr_CustomImplementation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconData>.NativeClassPtr, nameof (CustomImplementation));
      MapIconData.NativeFieldInfoPtr_AllySetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconData>.NativeClassPtr, nameof (AllySetting));
      MapIconData.NativeFieldInfoPtr_EnemySetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconData>.NativeClassPtr, nameof (EnemySetting));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
