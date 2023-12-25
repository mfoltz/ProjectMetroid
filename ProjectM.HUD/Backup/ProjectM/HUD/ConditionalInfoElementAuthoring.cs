// Decompiled with JetBrains decompiler
// Type: ProjectM.HUD.ConditionalInfoElementAuthoring
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.HUD
{
  [Serializable]
  public class ConditionalInfoElementAuthoring : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Text;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_Placement;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Conditional;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_ConditionalInfoElement_MonoBehaviour_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211818, XrefRangeEnd = 1211820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConditionalInfoElement Convert(MonoBehaviour converter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) converter);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionalInfoElementAuthoring.NativeMethodInfoPtr_Convert_Public_ConditionalInfoElement_MonoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ConditionalInfoElement*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConditionalInfoElementAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalInfoElementAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConditionalInfoElementAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ConditionalInfoElementAuthoring()
    {
      Il2CppClassPointerStore<ConditionalInfoElementAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.HUD", nameof (ConditionalInfoElementAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalInfoElementAuthoring>.NativeClassPtr);
      ConditionalInfoElementAuthoring.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalInfoElementAuthoring>.NativeClassPtr, nameof (Text));
      ConditionalInfoElementAuthoring.NativeFieldInfoPtr_LocalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalInfoElementAuthoring>.NativeClassPtr, nameof (LocalOffset));
      ConditionalInfoElementAuthoring.NativeFieldInfoPtr_Placement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalInfoElementAuthoring>.NativeClassPtr, nameof (Placement));
      ConditionalInfoElementAuthoring.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalInfoElementAuthoring>.NativeClassPtr, nameof (Type));
      ConditionalInfoElementAuthoring.NativeFieldInfoPtr_Conditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalInfoElementAuthoring>.NativeClassPtr, nameof (Conditional));
      ConditionalInfoElementAuthoring.NativeMethodInfoPtr_Convert_Public_ConditionalInfoElement_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalInfoElementAuthoring>.NativeClassPtr, 100663798);
      ConditionalInfoElementAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalInfoElementAuthoring>.NativeClassPtr, 100663799);
    }

    public ConditionalInfoElementAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizationKey Text
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalInfoElementAuthoring.NativeFieldInfoPtr_Text));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalInfoElementAuthoring.NativeFieldInfoPtr_Text)) = value;
      }
    }

    public unsafe Vector3 LocalOffset
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalInfoElementAuthoring.NativeFieldInfoPtr_LocalOffset));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalInfoElementAuthoring.NativeFieldInfoPtr_LocalOffset)) = value;
      }
    }

    public unsafe InfoTextPlacement Placement
    {
      get
      {
        return *(InfoTextPlacement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalInfoElementAuthoring.NativeFieldInfoPtr_Placement));
      }
      [param: In] set
      {
        *(InfoTextPlacement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalInfoElementAuthoring.NativeFieldInfoPtr_Placement)) = value;
      }
    }

    public unsafe InfoTextType Type
    {
      get
      {
        return *(InfoTextType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalInfoElementAuthoring.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(InfoTextType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalInfoElementAuthoring.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Conditional
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalInfoElementAuthoring.NativeFieldInfoPtr_Conditional));
        return pointer == System.IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConditionalInfoElementAuthoring.NativeFieldInfoPtr_Conditional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
