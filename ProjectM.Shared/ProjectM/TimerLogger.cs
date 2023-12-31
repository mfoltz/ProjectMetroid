// Decompiled with JetBrains decompiler
// Type: ProjectM.TimerLogger
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public sealed class TimerLogger : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CreatedAt;
    private static readonly System.IntPtr NativeFieldInfoPtr__TimerName;
    private static readonly System.IntPtr NativeMethodInfoPtr_Timer_Public_Static_TimerLogger_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 765758, RefRangeEnd = 765760, XrefRangeStart = 765753, XrefRangeEnd = 765758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TimerLogger Timer(string timerName)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(timerName);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TimerLogger.NativeMethodInfoPtr_Timer_Public_Static_TimerLogger_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new TimerLogger(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765760, XrefRangeEnd = 765765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TimerLogger(string timerName)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerLogger>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(timerName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TimerLogger.NativeMethodInfoPtr__ctor_Private_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 765783, RefRangeEnd = 765787, XrefRangeStart = 765765, XrefRangeEnd = 765783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TimerLogger.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TimerLogger()
    {
      Il2CppClassPointerStore<TimerLogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TimerLogger));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerLogger>.NativeClassPtr);
      TimerLogger.NativeFieldInfoPtr__CreatedAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerLogger>.NativeClassPtr, nameof (_CreatedAt));
      TimerLogger.NativeFieldInfoPtr__TimerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerLogger>.NativeClassPtr, nameof (_TimerName));
      TimerLogger.NativeMethodInfoPtr_Timer_Public_Static_TimerLogger_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerLogger>.NativeClassPtr, 100667655);
      TimerLogger.NativeMethodInfoPtr__ctor_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerLogger>.NativeClassPtr, 100667656);
      TimerLogger.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerLogger>.NativeClassPtr, 100667657);
    }

    public TimerLogger(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public TimerLogger()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TimerLogger>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimerLogger>.NativeClassPtr, data));
    }

    public unsafe Il2CppSystem.DateTime _CreatedAt
    {
      get
      {
        return *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimerLogger.NativeFieldInfoPtr__CreatedAt));
      }
      [param: In] set
      {
        *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimerLogger.NativeFieldInfoPtr__CreatedAt)) = value;
      }
    }

    public unsafe string _TimerName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimerLogger.NativeFieldInfoPtr__TimerName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimerLogger.NativeFieldInfoPtr__TimerName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
