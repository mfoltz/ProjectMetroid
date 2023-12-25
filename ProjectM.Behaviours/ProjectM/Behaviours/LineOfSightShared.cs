// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.LineOfSightShared
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  public static class LineOfSightShared : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMapCollisionRadius_Public_Static_Single_Boolean_byref_MapCollision_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1344946, RefRangeEnd = 1344947, XrefRangeStart = 1344945, XrefRangeEnd = 1344946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetMapCollisionRadius(bool ignoreSize, [In] ref MapCollision mapCollision)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &ignoreSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LineOfSightShared.NativeMethodInfoPtr_GetMapCollisionRadius_Public_Static_Single_Boolean_byref_MapCollision_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static LineOfSightShared()
    {
      Il2CppClassPointerStore<LineOfSightShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (LineOfSightShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineOfSightShared>.NativeClassPtr);
      LineOfSightShared.NativeMethodInfoPtr_GetMapCollisionRadius_Public_Static_Single_Boolean_byref_MapCollision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineOfSightShared>.NativeClassPtr, 100665484);
    }

    public LineOfSightShared(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
