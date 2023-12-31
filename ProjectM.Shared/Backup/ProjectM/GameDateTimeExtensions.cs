// Decompiled with JetBrains decompiler
// Type: ProjectM.GameDateTimeExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class GameDateTimeExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ToTimeString_Public_Static_String_byref_GameDateTime_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInTimeSpan_Public_Static_Boolean_byref_GameDateTime_byref_DayTimeSpan_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TimeValueCheck_Private_Static_Boolean_Int32_Int32_Int32_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724484, XrefRangeEnd = 724522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string ToTimeString([In] ref this GameDateTime dateTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref dateTime;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GameDateTimeExtensions.NativeMethodInfoPtr_ToTimeString_Public_Static_String_byref_GameDateTime_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 724522, RefRangeEnd = 724526, XrefRangeStart = 724522, XrefRangeEnd = 724522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsInTimeSpan([In] ref this GameDateTime dateTime, [In] ref DayTimeSpan timeSpan)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref dateTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref timeSpan;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDateTimeExtensions.NativeMethodInfoPtr_IsInTimeSpan_Public_Static_Boolean_byref_GameDateTime_byref_DayTimeSpan_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool TimeValueCheck(int start, int end, int currentVal)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &currentVal;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDateTimeExtensions.NativeMethodInfoPtr_TimeValueCheck_Private_Static_Boolean_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static GameDateTimeExtensions()
    {
      Il2CppClassPointerStore<GameDateTimeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameDateTimeExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDateTimeExtensions>.NativeClassPtr);
      GameDateTimeExtensions.NativeMethodInfoPtr_ToTimeString_Public_Static_String_byref_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTimeExtensions>.NativeClassPtr, 100664071);
      GameDateTimeExtensions.NativeMethodInfoPtr_IsInTimeSpan_Public_Static_Boolean_byref_GameDateTime_byref_DayTimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTimeExtensions>.NativeClassPtr, 100664072);
      GameDateTimeExtensions.NativeMethodInfoPtr_TimeValueCheck_Private_Static_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTimeExtensions>.NativeClassPtr, 100664073);
    }

    public GameDateTimeExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
