// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilitySystemDebug
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Burst;

#nullable disable
namespace ProjectM
{
  public class AbilitySystemDebug : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DebugLogs;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilitySystemDebug()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilitySystemDebug>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilitySystemDebug.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilitySystemDebug()
    {
      Il2CppClassPointerStore<AbilitySystemDebug>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (AbilitySystemDebug));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilitySystemDebug>.NativeClassPtr);
      AbilitySystemDebug.NativeFieldInfoPtr_DebugLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilitySystemDebug>.NativeClassPtr, nameof (DebugLogs));
      AbilitySystemDebug.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilitySystemDebug>.NativeClassPtr, 100664333);
    }

    public AbilitySystemDebug(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe SharedStatic<AbilitySystemDebug.Data> DebugLogs
    {
      get
      {
        SharedStatic<AbilitySystemDebug.Data> debugLogs;
        IL2CPP.il2cpp_field_static_get_value(AbilitySystemDebug.NativeFieldInfoPtr_DebugLogs, (void*) &debugLogs);
        return debugLogs;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AbilitySystemDebug.NativeFieldInfoPtr_DebugLogs, (void*) &value);
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Data
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Enabled;
      [FieldOffset(0)]
      public bool Enabled;

      static Data()
      {
        Il2CppClassPointerStore<AbilitySystemDebug.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilitySystemDebug>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilitySystemDebug.Data>.NativeClassPtr);
        AbilitySystemDebug.Data.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilitySystemDebug.Data>.NativeClassPtr, nameof (Enabled));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilitySystemDebug.Data>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public class DataFieldKey : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe DataFieldKey()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilitySystemDebug.DataFieldKey>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilitySystemDebug.DataFieldKey.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static DataFieldKey()
      {
        Il2CppClassPointerStore<AbilitySystemDebug.DataFieldKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilitySystemDebug>.NativeClassPtr, nameof (DataFieldKey));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilitySystemDebug.DataFieldKey>.NativeClassPtr);
        AbilitySystemDebug.DataFieldKey.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilitySystemDebug.DataFieldKey>.NativeClassPtr, 100664335);
      }

      public DataFieldKey(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
