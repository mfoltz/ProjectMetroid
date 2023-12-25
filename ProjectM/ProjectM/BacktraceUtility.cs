// Decompiled with JetBrains decompiler
// Type: ProjectM.BacktraceUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Backtrace.Unity.Model;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class BacktraceUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Boolean_Func_2_BacktraceData_BacktraceData_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 977446, RefRangeEnd = 977449, XrefRangeStart = 977409, XrefRangeEnd = 977446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Initialize(
      bool isServer,
      Il2CppSystem.Func<BacktraceData, BacktraceData> beforeSend)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &isServer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) beforeSend);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BacktraceUtility.NativeMethodInfoPtr_Initialize_Public_Static_Void_Boolean_Func_2_BacktraceData_BacktraceData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BacktraceUtility()
    {
      Il2CppClassPointerStore<BacktraceUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BacktraceUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BacktraceUtility>.NativeClassPtr);
      BacktraceUtility.NativeMethodInfoPtr_Initialize_Public_Static_Void_Boolean_Func_2_BacktraceData_BacktraceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacktraceUtility>.NativeClassPtr, 100675541);
    }

    public BacktraceUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static class CustomAttributeKeys : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_APPLICATION_TYPE;
      private static readonly System.IntPtr NativeFieldInfoPtr_DEBUG_EVENTS_LEVEL;
      private static readonly System.IntPtr NativeFieldInfoPtr_LAN_MODE_ENABLED;

      static CustomAttributeKeys()
      {
        Il2CppClassPointerStore<BacktraceUtility.CustomAttributeKeys>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BacktraceUtility>.NativeClassPtr, nameof (CustomAttributeKeys));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BacktraceUtility.CustomAttributeKeys>.NativeClassPtr);
        BacktraceUtility.CustomAttributeKeys.NativeFieldInfoPtr_APPLICATION_TYPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacktraceUtility.CustomAttributeKeys>.NativeClassPtr, nameof (APPLICATION_TYPE));
        BacktraceUtility.CustomAttributeKeys.NativeFieldInfoPtr_DEBUG_EVENTS_LEVEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacktraceUtility.CustomAttributeKeys>.NativeClassPtr, nameof (DEBUG_EVENTS_LEVEL));
        BacktraceUtility.CustomAttributeKeys.NativeFieldInfoPtr_LAN_MODE_ENABLED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacktraceUtility.CustomAttributeKeys>.NativeClassPtr, nameof (LAN_MODE_ENABLED));
      }

      public CustomAttributeKeys(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe string APPLICATION_TYPE
      {
        get
        {
          System.IntPtr il2CppString;
          IL2CPP.il2cpp_field_static_get_value(BacktraceUtility.CustomAttributeKeys.NativeFieldInfoPtr_APPLICATION_TYPE, (void*) &il2CppString);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BacktraceUtility.CustomAttributeKeys.NativeFieldInfoPtr_APPLICATION_TYPE, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public static unsafe string DEBUG_EVENTS_LEVEL
      {
        get
        {
          System.IntPtr il2CppString;
          IL2CPP.il2cpp_field_static_get_value(BacktraceUtility.CustomAttributeKeys.NativeFieldInfoPtr_DEBUG_EVENTS_LEVEL, (void*) &il2CppString);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BacktraceUtility.CustomAttributeKeys.NativeFieldInfoPtr_DEBUG_EVENTS_LEVEL, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public static unsafe string LAN_MODE_ENABLED
      {
        get
        {
          System.IntPtr il2CppString;
          IL2CPP.il2cpp_field_static_get_value(BacktraceUtility.CustomAttributeKeys.NativeFieldInfoPtr_LAN_MODE_ENABLED, (void*) &il2CppString);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BacktraceUtility.CustomAttributeKeys.NativeFieldInfoPtr_LAN_MODE_ENABLED, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }

    [ObfuscatedName("ProjectM.BacktraceUtility/<>c__DisplayClass0_0")]
    public sealed class __c__DisplayClass0_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_beforeSend;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_BacktraceData_BacktraceData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BacktraceUtility.__c__DisplayClass0_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BacktraceUtility.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977389, XrefRangeEnd = 977409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BacktraceData _Initialize_b__0(BacktraceData data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BacktraceUtility.__c__DisplayClass0_0.NativeMethodInfoPtr__Initialize_b__0_Internal_BacktraceData_BacktraceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (BacktraceData) null : new BacktraceData(pointer);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<BacktraceUtility.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BacktraceUtility>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BacktraceUtility.__c__DisplayClass0_0>.NativeClassPtr);
        BacktraceUtility.__c__DisplayClass0_0.NativeFieldInfoPtr_beforeSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacktraceUtility.__c__DisplayClass0_0>.NativeClassPtr, nameof (beforeSend));
        BacktraceUtility.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacktraceUtility.__c__DisplayClass0_0>.NativeClassPtr, 100675543);
        BacktraceUtility.__c__DisplayClass0_0.NativeMethodInfoPtr__Initialize_b__0_Internal_BacktraceData_BacktraceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacktraceUtility.__c__DisplayClass0_0>.NativeClassPtr, 100675544);
      }

      public __c__DisplayClass0_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Il2CppSystem.Func<BacktraceData, BacktraceData> beforeSend
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacktraceUtility.__c__DisplayClass0_0.NativeFieldInfoPtr_beforeSend));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<BacktraceData, BacktraceData>) null : new Il2CppSystem.Func<BacktraceData, BacktraceData>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacktraceUtility.__c__DisplayClass0_0.NativeFieldInfoPtr_beforeSend), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
