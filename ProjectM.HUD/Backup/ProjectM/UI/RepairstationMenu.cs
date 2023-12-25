// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.RepairstationMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class RepairstationMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InventorySubMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr_RepairstationSubMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubMenusParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalizationKeys;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RepairstationMenu.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RepairstationMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RepairstationMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RepairstationMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RepairstationMenu()
    {
      Il2CppClassPointerStore<RepairstationMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (RepairstationMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepairstationMenu>.NativeClassPtr);
      RepairstationMenu.NativeFieldInfoPtr_InventorySubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairstationMenu>.NativeClassPtr, nameof (InventorySubMenu));
      RepairstationMenu.NativeFieldInfoPtr_RepairstationSubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairstationMenu>.NativeClassPtr, nameof (RepairstationSubMenu));
      RepairstationMenu.NativeFieldInfoPtr_SubMenusParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairstationMenu>.NativeClassPtr, nameof (SubMenusParent));
      RepairstationMenu.NativeFieldInfoPtr_LocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairstationMenu>.NativeClassPtr, nameof (LocalizationKeys));
      RepairstationMenu.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairstationMenu>.NativeClassPtr, 100666230);
      RepairstationMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairstationMenu>.NativeClassPtr, 100666231);
    }

    public RepairstationMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe InventorySubMenu InventorySubMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairstationMenu.NativeFieldInfoPtr_InventorySubMenu));
        return pointer == System.IntPtr.Zero ? (InventorySubMenu) null : new InventorySubMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepairstationMenu.NativeFieldInfoPtr_InventorySubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RepairstationSubMenu RepairstationSubMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairstationMenu.NativeFieldInfoPtr_RepairstationSubMenu));
        return pointer == System.IntPtr.Zero ? (RepairstationSubMenu) null : new RepairstationSubMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepairstationMenu.NativeFieldInfoPtr_RepairstationSubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SubMenusParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairstationMenu.NativeFieldInfoPtr_SubMenusParent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepairstationMenu.NativeFieldInfoPtr_SubMenusParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InventoryLocalizationKeys LocalizationKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RepairstationMenu.NativeFieldInfoPtr_LocalizationKeys));
        return pointer == System.IntPtr.Zero ? (InventoryLocalizationKeys) null : new InventoryLocalizationKeys(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RepairstationMenu.NativeFieldInfoPtr_LocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InitData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TargetWorkstation;
      private static readonly System.IntPtr NativeFieldInfoPtr_InteractBuff;
      [FieldOffset(0)]
      public Entity TargetWorkstation;
      [FieldOffset(8)]
      public Entity InteractBuff;

      static InitData()
      {
        Il2CppClassPointerStore<RepairstationMenu.InitData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RepairstationMenu>.NativeClassPtr, nameof (InitData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepairstationMenu.InitData>.NativeClassPtr);
        RepairstationMenu.InitData.NativeFieldInfoPtr_TargetWorkstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairstationMenu.InitData>.NativeClassPtr, nameof (TargetWorkstation));
        RepairstationMenu.InitData.NativeFieldInfoPtr_InteractBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairstationMenu.InitData>.NativeClassPtr, nameof (InteractBuff));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RepairstationMenu.InitData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
