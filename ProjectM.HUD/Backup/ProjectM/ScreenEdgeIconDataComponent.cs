// Decompiled with JetBrains decompiler
// Type: ProjectM.ScreenEdgeIconDataComponent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ScreenEdgeIconDataComponent : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowArrow;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideDistanceWhenClose;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScreenEdgeIconDataComponent.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ScreenEdgeIconDataComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenEdgeIconDataComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScreenEdgeIconDataComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ScreenEdgeIconDataComponent()
    {
      Il2CppClassPointerStore<ScreenEdgeIconDataComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM", nameof (ScreenEdgeIconDataComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenEdgeIconDataComponent>.NativeClassPtr);
      ScreenEdgeIconDataComponent.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconDataComponent>.NativeClassPtr, nameof (Icon));
      ScreenEdgeIconDataComponent.NativeFieldInfoPtr_ShowArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconDataComponent>.NativeClassPtr, nameof (ShowArrow));
      ScreenEdgeIconDataComponent.NativeFieldInfoPtr_ShowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconDataComponent>.NativeClassPtr, nameof (ShowDistance));
      ScreenEdgeIconDataComponent.NativeFieldInfoPtr_HideDistanceWhenClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconDataComponent>.NativeClassPtr, nameof (HideDistanceWhenClose));
      ScreenEdgeIconDataComponent.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenEdgeIconDataComponent>.NativeClassPtr, 100663761);
      ScreenEdgeIconDataComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenEdgeIconDataComponent>.NativeClassPtr, 100663762);
    }

    public ScreenEdgeIconDataComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Sprite Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconDataComponent.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconDataComponent.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool ShowArrow
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconDataComponent.NativeFieldInfoPtr_ShowArrow));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconDataComponent.NativeFieldInfoPtr_ShowArrow)) = value;
      }
    }

    public unsafe bool ShowDistance
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconDataComponent.NativeFieldInfoPtr_ShowDistance));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconDataComponent.NativeFieldInfoPtr_ShowDistance)) = value;
      }
    }

    public unsafe bool HideDistanceWhenClose
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconDataComponent.NativeFieldInfoPtr_HideDistanceWhenClose));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconDataComponent.NativeFieldInfoPtr_HideDistanceWhenClose)) = value;
      }
    }
  }
}
