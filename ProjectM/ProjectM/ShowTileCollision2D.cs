// Decompiled with JetBrains decompiler
// Type: ProjectM.ShowTileCollision2D
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ShowTileCollision2D
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowNoCollision;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_IShowTileGridComponentData_get_Radius_Private_Virtual_Final_New_get_Single_0;
    [FieldOffset(0)]
    public float Radius;
    [FieldOffset(4)]
    public bool ShowNoCollision;

    public virtual unsafe float ProjectM\u002EIShowTileGridComponentData\u002ERadius
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 538356, RefRangeEnd = 538358, XrefRangeStart = 538356, XrefRangeEnd = 538358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowTileCollision2D.NativeMethodInfoPtr_ProjectM_IShowTileGridComponentData_get_Radius_Private_Virtual_Final_New_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static ShowTileCollision2D()
    {
      Il2CppClassPointerStore<ShowTileCollision2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ShowTileCollision2D));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTileCollision2D>.NativeClassPtr);
      ShowTileCollision2D.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2D>.NativeClassPtr, nameof (Radius));
      ShowTileCollision2D.NativeFieldInfoPtr_ShowNoCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollision2D>.NativeClassPtr, nameof (ShowNoCollision));
      ShowTileCollision2D.NativeMethodInfoPtr_ProjectM_IShowTileGridComponentData_get_Radius_Private_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollision2D>.NativeClassPtr, 100684659);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTileCollision2D>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
