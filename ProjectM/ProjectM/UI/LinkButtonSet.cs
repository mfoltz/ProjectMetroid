// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.LinkButtonSet
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class LinkButtonSet : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_LinksParentNode;
    private static readonly IntPtr NativeFieldInfoPtr_LinkButtonPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_LinksData;
    private static readonly IntPtr NativeFieldInfoPtr__LinkButtonsCache;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161516, XrefRangeEnd = 1161523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LinkButtonSet.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161523, XrefRangeEnd = 1161535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LinkButtonSet.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LinkButtonSet()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkButtonSet>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LinkButtonSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LinkButtonSet()
    {
      Il2CppClassPointerStore<LinkButtonSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (LinkButtonSet));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkButtonSet>.NativeClassPtr);
      LinkButtonSet.NativeFieldInfoPtr_LinksParentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkButtonSet>.NativeClassPtr, nameof (LinksParentNode));
      LinkButtonSet.NativeFieldInfoPtr_LinkButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkButtonSet>.NativeClassPtr, nameof (LinkButtonPrefab));
      LinkButtonSet.NativeFieldInfoPtr_LinksData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkButtonSet>.NativeClassPtr, nameof (LinksData));
      LinkButtonSet.NativeFieldInfoPtr__LinkButtonsCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkButtonSet>.NativeClassPtr, nameof (_LinkButtonsCache));
      LinkButtonSet.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkButtonSet>.NativeClassPtr, 100692380);
      LinkButtonSet.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkButtonSet>.NativeClassPtr, 100692381);
      LinkButtonSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkButtonSet>.NativeClassPtr, 100692382);
    }

    public LinkButtonSet(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RectTransform LinksParentNode
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinkButtonSet.NativeFieldInfoPtr_LinksParentNode));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinkButtonSet.NativeFieldInfoPtr_LinksParentNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LinkButton LinkButtonPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinkButtonSet.NativeFieldInfoPtr_LinkButtonPrefab));
        return pointer == IntPtr.Zero ? (LinkButton) null : new LinkButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinkButtonSet.NativeFieldInfoPtr_LinkButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LinksDataAsset LinksData
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinkButtonSet.NativeFieldInfoPtr_LinksData));
        return pointer == IntPtr.Zero ? (LinksDataAsset) null : new LinksDataAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinkButtonSet.NativeFieldInfoPtr_LinksData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<LinkButton> _LinkButtonsCache
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinkButtonSet.NativeFieldInfoPtr__LinkButtonsCache));
        return pointer == IntPtr.Zero ? (UI_Cache<LinkButton>) null : new UI_Cache<LinkButton>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinkButtonSet.NativeFieldInfoPtr__LinkButtonsCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
